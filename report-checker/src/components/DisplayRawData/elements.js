import styled from 'styled-components'
import { Backdrop } from '../commons/styles/backdrop'

export const Container = styled.div`
  ${Backdrop}
  z-index: 10;

  & button:hover {
    background-color: var(--color-2);
  }
`
export const Wrapper = styled.div`
  width: calc(var(--main-width) * 0.8);
  height: calc(var(--main-height) * 0.8);
  min-width: calc(var(--main-width) * 0.8);
  min-height: calc(var(--main-height) * 0.8);
  clip-path: polygon(95% 0, 100% 10%, 100% 100%, 0 100%, 0 0);
  background-color: var(--color-8);
  position: relative;
  padding: var(--padding);
  display: flex;
  gap: var(--gap-1);
  justify-content: flex-end;
  align-items: flex-end;
  transform: scale(0.7);
  animation: kf-scale 0.5s 0s ease-in-out forwards;

  @keyframes kf-scale {
    100% {
      transform: scale(1);
    }
  }
`
export const Content = styled.div`
  position: absolute;
  inset: 0 0 calc(var(--padding) * 3.6 + var(--font-size-small)) 0;
  padding: var(--padding);
  background-color: var(--color-9);
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const Main = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  gap: var(--gap-1);
`
