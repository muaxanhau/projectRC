import React from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Redirect
} from 'react-router-dom'
import { GlobalStyle } from './constants/GlobalStyle'
import Loading from './features/Loading/index'
import Alert from './features/Alert/index'
import PrivateRoute from './features/PrivateRoute/index'
import Login from './pages/Login/index'
import Home from './pages/Home/index'
import NotFound from './pages/NotFound/index'

const App = () => {
  return (
    <>
      <GlobalStyle />
      <Loading />
      <Alert />
      <Router>
        <Switch>
          <Route exact path='/'>
            <Redirect to='/login' />
          </Route>
          <Route exact path='/login'>
            <Login />
          </Route>
          <PrivateRoute path='/home'>
            <Home />
          </PrivateRoute>
          <Route path='/*'>
            <NotFound />
          </Route>
        </Switch>
      </Router>
    </>
  )
}

export default App
