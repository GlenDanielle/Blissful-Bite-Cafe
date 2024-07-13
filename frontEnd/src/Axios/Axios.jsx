import axios from 'axios'

//axios.defaults.withCredentials = true;
axios.defaults.headers.post['Content-Type'] = 'application/json';
axios.defaults.headers.common['Accept'] = 'application/json';

//const BackEndBaseUrl = //lagay mo dito url ng backEnd

const AxiosTryGet = axios.create({
    BackEndBaseUrl: baseUrl
})

export {AxiosTryGet}