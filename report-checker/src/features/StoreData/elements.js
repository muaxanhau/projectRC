import styled from 'styled-components'
import { Backdrop } from '../../components/commons/styles/backdrop'
import { FormLayoutCss } from '../../components/commons/styles/polygon'

export const Container = styled.div`
  ${Backdrop}
  z-index: var(--index-3);

  & button:hover {
    background-color: var(--color-2);
  }
`
export const Wrapper = styled.div`
  width: calc(var(--main-width) * 0.5);
  min-width: calc(var(--main-width) * 0.5);
  ${FormLayoutCss}
  background-color: var(--color-8);
  transform: scale(0.7);
  animation: kf-scale 0.5s 0s ease-in-out forwards;

  @keyframes kf-scale {
    100% {
      transform: scale(1);
    }
  }
`
export const Content = styled.div`
  width: 100%;
  padding: var(--padding);
  background-color: var(--color-9);
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const Main = styled.div`
  width: 100%;
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
`
export const Option = styled.div`
  display: flex;
  gap: var(--gap-1);
  align-items: center;

  color: white;
  font-family: roboto;
`
export const ButtonArea = styled.div`
  padding: var(--padding);
  display: flex;
  justify-content: flex-end;
  align-items: center;
  gap: var(--gap-1);
`
