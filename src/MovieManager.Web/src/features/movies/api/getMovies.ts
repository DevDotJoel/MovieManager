import { useQuery } from "@tanstack/react-query";
import { axiosInstance } from "../../../libs/axios";
import { ExtractFnReturnType, QueryConfig } from "../../../libs/react-query";
import { MovieModel } from "../types";

export const getMovies = (): Promise<MovieModel[]> => {
    return axiosInstance.get('/movie');
  };
  type QueryFnType = typeof getMovies;
  type UseMoviesOptions = {
    config?: QueryConfig<QueryFnType>;
  };
  export const useMovies = ({ config }: UseMoviesOptions = {}) => {
    return useQuery<ExtractFnReturnType<QueryFnType>>({
      ...config,
      queryKey: ['movies'],
      queryFn: () => getMovies(),
    });
  };