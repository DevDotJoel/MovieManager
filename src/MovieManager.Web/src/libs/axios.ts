
import axios from "axios";
import { API_URL } from "../config";

  export const axiosInstance = axios.create({
    baseURL: API_URL,
  });
  axiosInstance.interceptors.response.use(
    (response) => {
      return response.data;
    },
    (error) => {
      const message = error.response?.data?.message || error.message;
      // useNotificationStore.getState().addNotification({
      //   type: 'error',
      //   title: 'Error',
      //   message,
      // });
  
      return Promise.reject(error);
    }
  );