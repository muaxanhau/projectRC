import styled from 'styled-components'
import { Backdrop } from './../../styles/backdrop'
import { Polygon1 } from './../../styles/polygon'

export const Container = styled.div`
  ${Backdrop}
  z-index: var(--index-3);

  & button:hover {
    background-color: var(--color-2-10);
  }
`
export const Wrapper = styled.div`
  --width-default: calc(var(--main-width) * 0.6);
  width: ${({ width }) => width ?? 'var(--width-default)'};
  min-width: ${({ width }) => width ?? 'var(--width-default)'};
  ${Polygon1}
  background-color: var(--color-8-11);
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
  min-height: 80px;
  padding: var(--padding);
  background-color: var(--color-9-10);
  display: flex;
  flex-direction: column;
  gap: var(--gap-2);
`
export const Main = styled.div`
  width: 100%;
`
export const ButtonArea = styled.div`
  padding: var(--padding);
  display: flex;
  justify-content: flex-end;
  align-items: center;
  gap: var(--gap-1);
`
