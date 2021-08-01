import styled from 'styled-components'
import { Shadow1 } from '../../components/commons/styles/shadow'

export const Container = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
`
export const Wrapper = styled.div`
  --width-total: 550px;
  --height: 350px;
  --width-login-area: 55%;
  border-radius: var(--border-radius-1);
  background-color: var(--color-1);
  position: relative;
  min-width: var(--width-total);
  height: var(--height);
  padding: var(--padding);
  position: relative;

  ${Shadow1}
  &:before, &:after {
    content: '';
    position: absolute;
    inset: var(--t-r, 0) var(--t-r, 0) var(--b-l, 0) var(--b-l, 0);
    background: linear-gradient(
      var(--deg),
      transparent,
      transparent,
      var(--clr)
    );
    filter: blur(20px);
    z-index: -1;
  }
  &:before {
    --t-r: -10px;
    --clr: var(--color-4);
    --deg: 45deg;
  }
  &:after {
    --b-l: -10px;
    --clr: var(--color-5);
    --deg: 225deg;
  }
`
export const IntroArea = styled.div`
  position: absolute;
  top: 50%;
  left: calc((100% - var(--width-login-area)) / 2);
  transform: translate(-50%, -50%);
  display: flex;
  flex-direction: column;
  gap: 2rem;
  align-items: center;
`
export const LoginArea = styled.div`
  width: var(--width-login-area);
  height: 100%;
  border-radius: var(--border-radius-2);
  float: right;
  background-color: var(--color-6);
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: 2rem;
`
export const InputArea = styled.form`
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 0.5rem;
`
