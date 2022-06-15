import axios, { AxiosResponse } from "axios";

const config = {
  withCredentials: true,
};

export function getUserId(): Promise<
  AxiosResponse<{ Id: string; Name: string }>
> {
  return axios.get("http://localhost:82/user/get-logged-id", config);
}

export function logIn(username: string, password: string): Promise<boolean> {
  const data = {
    username,
    password,
  };
  return axios
    .post("http://localhost:82/user/login", data, config)
    .then(() => {
      return true;
    })
    .catch(() => {
      return false;
    });
}

export function logOut(): Promise<AxiosResponse<any>> {
  return axios.post("http://localhost:82/user/logout", {}, config);
}
