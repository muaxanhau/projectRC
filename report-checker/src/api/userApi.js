import axiosClient from './axiosClient'
import Api from './../constants/Api'

const userApi = {
  login: (data = { username: '', password: '' }) => {
    const url = Api.USER_LOGIN
    return axiosClient.post(url, data)
  },
  checkToken: () => {
    const url = Api.USER_CHECK_TOKEN
    const config = {
      headers: {
        Authorization: `${Api.AUTHORIZATION_TYPE} ${localStorage.getItem(
          'token'
        )}`
      }
    }
    return axiosClient.get(url, config)
  }
}

export default userApi
