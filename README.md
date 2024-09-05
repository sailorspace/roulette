# roulette- Ivory Ball technique 

## Development Setup

### Prerequisites
- .NET Core SDK
- Docker
- Dapr CLI
- Kubernetes CLI (kubectl) for deployment

### Running Applications Locally with Dapr

1. Start the Dapr dashboard:
   ```
   dapr dashboard
   ```
   Access the dashboard at http://localhost:8080/overview

2. Run backend services:
   ```
   dapr run --app-id weatherapi --app-port 5250 --dapr-http-port 3500 -- dotnet run
   dapr run --app-id bmsapi --app-port 5251 --dapr-http-port 3501 -- dotnet run
   dapr run --app-id hospitalapi --app-port 5252 --dapr-http-port 3502 -- dotnet run
   ```

3. Run frontend service:
   ```
   dapr run --app-id weatherfront --app-port 5002 --dapr-http-port 50002 -- dotnet run
   ```

## Deployment

### Using Docker Compose

1. Ensure you're in the directory containing the `docker-compose.yml` file.
2. Run the following command:
   ```
   docker-compose up
   ```
   This will start all services defined in the docker-compose file.

### Using Kubernetes

1. Update the `deployment.yml` file:
   - Replace `your-registry` with your actual container registry path.
   - Ensure all application image paths are correct.

2. Apply the deployment to your Kubernetes cluster:
   ```
   kubectl apply -f deployment.yml
   ```

3. Verify the deployment:
   ```
   kubectl get pods
   kubectl get services
   ```

Note: Ensure you have the necessary permissions and your kubectl is configured to interact with your intended Kubernetes cluster before deployment.




