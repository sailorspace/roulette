# roulette


dapr dashboard  
http://localhost:8080/overview

backend:-
dapr run --app-id weatherapi  --app-port 5250 --dapr-http-port 3500 -- dotnet run 

frontend:
dapr run --app-id weatherfront  --app-port 5002 --dapr-http-port 50002 -- dotnet run 



