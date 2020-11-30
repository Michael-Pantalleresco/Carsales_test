# Michael Pantalleresco Private Sell Coding challenge
### Assumptions:
- The UI didn't have to be perfect. 
- Docker would be used for deployment

#Run the API Application

in a new terminal build the docker image:
```shell script
$ cd michael.pantalleresc
$ docker build . -t private-sell
```
now we need to run the image:
```shell script
$ docker run -p 5001:5001 private-sell
```

now you can go to you browser and hit
```
https://localhost:5001/adverts
https://localhost:5001/details/{{advertId}} //advertId can be gotten from the 
adverts call
```

## Test the application
in a new terminal build the docker-compose
```shell script
$ cd Michael.Pantalleresco
$ docker-compose build
```

now we want to run the unit tests:
```shell script
$ cd Michael.Pantalleresco
$ docker-compose up
```

### Acceptance Tests
```shell script
$ cd Michael.Pantalleresco
$ docker build . -t sell
$ docker run -dp 5001:5001 sell
$ cd /Api/PrivateSellAcceptanceTests
$ dotnet test
```

# Run the Angular frontend
We need to make sure that the API is running
```shell script
$ cd Michael.Pantalleresco
$ docker build . -t sell
$ docker run -dp 5001:5001 sell
```

Now we can start up the angular app
```shell script
$ cd Web/ClientApp 
$ npm install
$ npm start
```
Now we can navigate to the frontend
```
http://localhost:4200/adverts
```

## Run the frontend Tests
```shell script
$ cd Web/ClientApp 
$ npm install
$ npm test
```

##Run Linting
```shell script
$ cd Web/ClientApp 
$ npm install
$ npm run lint
```

##Building the frontend
```shell script
$ cd Web/ClientApp 
$ npm install
$ npm run build
```