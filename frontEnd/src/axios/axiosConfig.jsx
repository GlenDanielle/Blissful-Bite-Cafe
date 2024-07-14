import axios from 'axios'

//axios.defaults.withCredentials = true;
axios.defaults.headers.post['Content-Type'] = 'application/json';
axios.defaults.headers.common['Accept'] = 'application/json';

const BackEndBaseUrl = import.meta.env.VITE_BackEndUrl;
//lagay mo dito url ng backEnd
console.log(BackEndBaseUrl)

const AxiosTryGet = axios.create({
    baseURL: `${BackEndBaseUrl}/orders`
})

export {AxiosTryGet}