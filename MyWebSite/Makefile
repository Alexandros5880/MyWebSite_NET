MAKE = TEST

PORT = 8000
CONTAINER_NAME = MyWebSite
IMAGE_NAME = alexandrosplatanios/mywebsite:last

delete:
	docker stop $(CONTAINER_NAME)
	docker image rm $(IMAGE_NAME) --force
	docker rm $(CONTAINER_NAME)


build:
	docker-compose build

run:
	docker-compose up -d

all: build run
