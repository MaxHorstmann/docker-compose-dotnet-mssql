#!/bin/bash
docker-compose up -d --build
docker attach local-dev
docker-compose down
