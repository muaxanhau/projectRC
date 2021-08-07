import React, { useState, useEffect } from 'react'
import { Route, Redirect } from 'react-router-dom'
import userApi from './../../api/userApi'

const PrivateRoute = ({ children, ...rest }) => {
  const [isLogedIn, setIslogedIn] = useState(true)

  useEffect(() => {
    const token = localStorage.getItem('token')
    if (!token) {
      setIslogedIn(prev => (prev = false))
      return
    }

    userApi
      .checkToken()
      .then(response => setIslogedIn(prev => (prev = true)))
      .catch(error => {
        setIslogedIn(prev => (prev = false))
        localStorage.removeItem('token')
      })
  })

  return isLogedIn ? (
    <Route {...rest}>{children}</Route>
  ) : (
    <Redirect to='/login' />
  )
}

export default PrivateRoute
