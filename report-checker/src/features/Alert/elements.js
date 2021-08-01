import styled from 'styled-components'
import { Backdrop } from '../../components/commons/styles/backdrop'

export const Container = styled.div`
  ${Backdrop}
  z-index: 100;

  & button:hover {
    background-color: var(--color-2);
  }
`
export const Wrapper = styled.div`
  width: calc(var(--main-width) * 0.6);
  height: 150px;
  min-width: calc(var(--main-width) * 0.6);
  clip-path: polygon(95% 0, 100% 20%, 100% 100%, 0 100%, 0 0);
  background-color: var(--color-8);
  position: relative;
  padding: var(--padding);
  display: flex;
  gap: var(--gap-1);
  justify-content: flex-end;
  align-items: flex-end;
  transform: scale(0.7);
  animation: kf-scale 0.2s 0s ease-in-out forwards;

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
  align-items: center;
`
export const Text = styled.p`
  color: var(--color-6);
  font-size: var(--font-size-medium);
`
