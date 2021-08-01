import axiosClient from './axiosClient'
import Api from './../constants/Api'

const dataApi = {
  transform: (data = { purestring: '', option: 0 }) => {
    const url = Api.DATA_TRANSFORM
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.post(url, data, config).then(response => response.items)
  },
  store: (data = { items: [] }) => {
    const url = Api.DATA_STORE
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.put(url, data, config)
  }
}

export default dataApi
