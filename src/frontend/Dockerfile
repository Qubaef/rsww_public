#build
FROM node:14.17.1 as build

WORKDIR /base
COPY . .
ARG API_HOST=localhost:82
RUN find . -type f -exec sed -i "s/localhost:82/$API_HOST/g" {} +

RUN yarn install
RUN yarn build

#webserver
FROM nginx:stable-alpine
COPY --from=build /base/dist /usr/share/nginx/html

COPY nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
