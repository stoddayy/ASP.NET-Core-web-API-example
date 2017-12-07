<h2>This project is my very first dive in to building ASP.NET Core web API's, after some configuration I finally managed to get MySql to play ball on my Mac (had to download connectors etc)</h2>

<h3>Working routes:</h3>

<b><i>GET http://localhost:5000/api/incident</b></i>
<br>Returns a list of all incidents stored in the database.

<b><i>GET http://localhost:5000/api/incident/{id}</b></i>
<br>Returns a single incident object if it is found in the DB.

<b><i>GET http://localhost:5000/api/user</b></i>
<br>Returns a list of all users stored in the database.

<h3>Future routes:</h3>

<b><i>POST http://localhost:5000/api/user</b></i>
<br>Adds a new user to the DB

<b><i>POST http://localhost:5000/api/location</b></i>
<br>Adds a new location to the DB

<b><i>POST http://localhost:5000/api/incident</b></i>
<br>Adds a new incident to the DB

<b><i>GET http://localhost:5000/api/user/{id}</b></i>
<br>Returns a single use if they are found in the DB.

<b><i>GET http://localhost:5000/api/location</b></i>
<br>Returns a list of all available locations.

<b><i>GET http://localhost:5000/api/location/{id}</b></i>
<br>Returns a single location if found.
