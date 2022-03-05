CONTAINER_NAME=MyWebSite
IMAGE_NAME=alexandrosplatanios/mywebsite:last
PORT=5000


delete:
	docker stop ${CONTAINER_NAME}
	docker image rm ${IMAGE_NAME} --force
	docker rm ${CONTAINER_NAME}

buildd: delete
	docker build -t ${IMAGE_NAME} .
	docker run -d -p ${PORT}:80 --name ${CONTAINER_NAME} ${IMAGE_NAME}


build:
	docker build -t ${IMAGE_NAME} .
	docker run -d -p ${PORT}:80 --name ${CONTAINER_NAME} ${IMAGE_NAME}




