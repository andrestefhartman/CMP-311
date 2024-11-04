const Joi = require('joi');
const express = require('express');
const app = express();

app.use(express.json());

const rifles = [
  {id: 1, caliber: '308', action: 'bolt'},
  {id: 2, caliber: '30-06', action: 'bolt'},
  {id: 3, caliber: '223', action: 'bolt'},
]

app.get('/', (req, res) => {
  res.send('Hello World!');
});

app.get('/api/rifles', (req, res) =>{
  res.send(rifles);
});

app.get('/api/rifles/:id', (req, res) =>{
  const rifle = rifles.find(c => c.id === parseInt(req.params.id));
  if (!rifle) res.status(404).send('The rifle with the given ID was not found');
  res.send(rifle);
});

app.post('/api/rifles', (req, res) =>{
  const result = validateRifle(req.body);
  const {error} = validateRifle(req.body);

  if (error) return res.status(400).send(error.details[0].message);
    
  

  const rifle = {
    id: rifles.length + 1,
    caliber: req.body.caliber,
    action: req.body.action
  };
  rifles.push(rifle);
  res.send(rifle);
});

app.put('/api/rifles/:id', (req, res) => {
  const rifle = rifles.find(c => c.id === parseInt(req.params.id));
  if (!rifle) return res.status(404).send('The rifle with the given ID was not found');

  const result = validateRifle(req.body);
  const {error} = validateRifle(req.body);
  if (error) return res.status(400).send(error.details[0].message);
    


  rifle.caliber = req.body.caliber;
  rifle.action = req.body.action;
  res.send(rifle)
})

app.delete('/api/rifles/:id', (req,res) => {
  const rifle = rifles.find(c => c.id === parseInt(req.params.id));
  if (!rifle) return res.status(404).send('The rifle with the given ID was not found');

  const index = rifles.indexOf(rifle);
  rifles.splice(index, 1);

  res.send(rifle);
});

function validateRifle(rifle) {
  const schema = {
    caliber: Joi.string().min(1).required(),
    action: Joi.string().min(1).required()
  };
  return Joi.validate(rifle, schema);
}


const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));