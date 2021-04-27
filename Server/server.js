var io = require('socket.io')(process.env.Port || 1337); // server is running on PORT 1337

console.log('server started');

const fs = require('fs')
var buffer = fs.readFileSync('./data/data.json').toString() // password to log in
var data = JSON.parse(buffer)

io.on('connection', function(socket){
	console.log('connected');

	socket.on('loginRequest', function(insertId, insertPw){ // recieve password called 'data'
		if(insertPw == data.string(insertId).password){
			socket.emit('login'); // send message to client that 'data' - our password is right - 200
		} else {
			socket.emit('wrongPassOrId') // send message to client that 'data' - our password isn't right - not 200
		}
	});

	socket.on('registerRequest', function(insertId, insertPw, name) {
		var user = { 
			insertId : {
				"name": name,
				"pw": insertPw
			}
		}
		fs.readFile('data.json', function (err) {
			data.push(user)
		
			fs.writeFile("data.json", JSON.stringify(data))
		})

	})
});