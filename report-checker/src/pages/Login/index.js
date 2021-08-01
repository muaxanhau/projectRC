import React from 'react'
import { Params } from './defaultValue'
import { Container, Wrapper, IntroArea, LoginArea, InputArea } from './elements'
import AppName from '../../components/commons/AppName/index'
import AppLogo from '../../components/commons/AppLogo/index'
import Title from '../../components/commons/Title/index'
import InputText from '../../components/commons/InputText'
import ButtonNormal from '../../components/commons/ButtonNormal'
import { useForm } from 'react-hook-form'
import { useHistory } from 'react-router-dom'
import { useDispatch } from 'react-redux'
import { loadingOn, loadingOff } from './../../features/Loading/loadingSlice'
import { alertOn } from './../../features/Alert/alertSlice'
import userApi from './../../api/userApi'

const Login = () => {
  const history = useHistory()
  const dispatch = useDispatch()

  const { register, handleSubmit } = useForm()
  const onSubmit = data => {
    dispatch(loadingOn({ text: 'Đang đăng nhập' }))
    userApi
      .login({ username: data.username, password: data.password })
      .then(response => {
        localStorage.clear()
        localStorage.setItem('token', response.token)
        history.push('/home')
      })
      .catch(e => {
        dispatch(
          alertOn({
            text: 'Đăng nhập thất bại!'
          })
        )
      })
      .finally(() => {
        dispatch(loadingOff())
      })
  }

  return (
    <Container>
      <Wrapper>
        <IntroArea>
          <AppName size={Params.AppName.size} />
          <AppLogo size={Params.AppLogo.size} />
        </IntroArea>
        <LoginArea>
          <Title text='Đăng nhập' size={Params.LoginTitle.size} />
          <InputArea onSubmit={handleSubmit(onSubmit)}>
            <InputText
              type='text'
              required
              placeholder='Tài khoản'
              icon={Params.InputText.icon.username}
              size={Params.InputText.size}
              width={Params.InputText.width}
              {...register('username')}
            />
            <InputText
              type='password'
              required
              placeholder='Mật khẩu'
              icon={Params.InputText.icon.password}
              size={Params.InputText.size}
              width={Params.InputText.width}
              {...register('password')}
            />

            <ButtonNormal
              text='Đăng nhập'
              type='submit'
              size={Params.Button.size}
            />
          </InputArea>
        </LoginArea>
      </Wrapper>
    </Container>
  )
}

export default Login
