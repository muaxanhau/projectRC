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
  },
  getAllItemsAndDetails: () => {
    const url = Api.DATA_GET_ALL_ITEMS_AND_DETAILS
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.get(url, config)
  },
  getAllNameOfItems: () => {
    const url = Api.DATA_GET_ALL_NAME_OF_ITEMS
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.get(url, config)
  },
  getItemDetailByName: (data = { name: '' }) => {
    const url = Api.DATA_GET_ITEM_DETAIL_BY_NAME
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.post(url, data, config)
  }
}

export default dataApi
