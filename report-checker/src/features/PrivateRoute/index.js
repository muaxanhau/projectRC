import React from 'react'
import { Route, Redirect } from 'react-router-dom'
import userApi from './../../api/userApi'

const PrivateRoute = ({ children, ...rest }) => {
  const token = localStorage.getItem('token')
  if (!token) {
    return <Redirect to='/' />
  }
  const result = userApi
    .checkToken()
    .then(response => true)
    .catch(e => false)
  if (result) {
    return <Route {...rest}>{children}</Route>
  } else {
    return <Redirect to='/' />
  }
}

export default PrivateRoute
