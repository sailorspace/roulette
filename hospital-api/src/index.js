const express = require('express');
const bodyParser = require('body-parser');
const { DaprServer } = require('@dapr/dapr');

const app = express();
app.use(bodyParser.json());

const port = 3002;
const daprPort = process.env.DAPR_HTTP_PORT || 3500;

const hospitals = [
  { id: 1, name: 'General Hospital', city: 'New York' },
  { id: 2, name: 'City Medical Center', city: 'Los Angeles' },
];

const patients = [
  { id: 1, name: 'John Doe', hospitalId: 1 },
  { id: 2, name: 'Jane Smith', hospitalId: 2 },
  { id: 3, name: 'Bob Johnson', hospitalId: 1 },
];

app.get('/hospitals', (req, res) => {
  res.json(hospitals);
});

app.get('/patients', (req, res) => {
  res.json(patients);
});

app.get('/hospitals/:id/patients', (req, res) => {
  const hospitalId = parseInt(req.params.id);
  const hospitalPatients = patients.filter(patient => patient.hospitalId === hospitalId);
  res.json(hospitalPatients);
});

const server = new DaprServer(port, daprPort);

server.app = app;

server.start().then(() => {
  console.log(`Hospital API is running on port ${port}`);
});
