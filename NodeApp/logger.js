const EventEmmitter = require('events');

var url = 'http://mylogger.io/log';

class Logger extends EventEmmitter {
  log(message){
    //Send an http
    console.log(message);

    this.emit('messageLogged', {id: 1, url: 'http://'});
}

}

module.exports = Logger;