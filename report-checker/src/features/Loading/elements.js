import styled, { css } from 'styled-components'

const KeyframeWidth = css`
  animation: kf-width 0.3s 0s ease-in-out forwards;
  @keyframes kf-width {
    0% {
      width: var(--width-begin);
    }
    100% {
      width: var(--width-end);
    }
  }
`
const KeyframeHeight = css`
  animation: kf-height 0.3s 0s ease-in-out forwards;
  @keyframes kf-height {
    0% {
      height: var(--height-begin);
    }
    100% {
      height: var(--height-end);
    }
  }
`
export const Container = styled.div`
  position: fixed;
  inset: 0;
  background-color: rgba(255, 255, 255, 0.2);
  backdrop-filter: blur(2px);
  display: flex;
  justify-content: center;
  align-items: center;
  overflow: hidden;
  z-index: var(--index-5);
`
export const Wrapper = styled.div`
  min-width: ${() => {
    let width = window.innerWidth
    let height = window.innerHeight
    return (width > height ? width : height) * 2
  }}px;
  aspect-ratio: 1;
  transform: rotate(135deg);

  animation: kf-rotate 0.2s 0.5s ease-in-out forwards;
  @keyframes kf-rotate {
    100% {
      transform: rotate(45deg);
    }
  }

  position: relative;

  &:before,
  &:after {
    content: '';
    position: absolute;
    top: 0;
    height: 100%;
    background-color: var(--color-2-11);
    opacity: 0.5;
    filter: blur(10px);

    --width-begin: 0;
    --width-end: 40%;
    ${KeyframeWidth}
  }
  &:before {
    left: 0;
  }
  &:after {
    right: 0;
  }
`
const TypeCss = css`
  position: absolute;
  opacity: 0.7;
  width: 7%;

  &:before {
    position: absolute;
    font-size: 1.3rem;
    width: 120%;
    color: var(--color-9-6);
    transform: rotate(-45deg);

    animation: kf-loading 1s infinite;
    @keyframes kf-loading {
      0% {
        opacity: 0;
      }
      100% {
        opacity: 0.5;
      }
    }
  }

  --height-begin: 0;
  --height-end: 45%;
  ${KeyframeHeight}
`
export const Type1 = styled.div`
  top: 0;
  left: 40%;
  background-color: var(--color-4-3);
  clip-path: polygon(0 0, 100% 0, 100% 84.5%, 0% 100%);

  &:before {
    content: '${({ text }) => text}';
    bottom: 1.2rem;
    left: 0;
    transform-origin: top left;
    text-align: right;
  }

  ${TypeCss}
`
export const Type2 = styled.div`
  bottom: 0;
  right: 40%;
  background-color: var(--color-5-3);
  clip-path: polygon(0 15.5%, 100% 0, 100% 100%, 0% 100%);

  &:before {
    content: '${({ text }) => text}';
    top: 1.2rem;
    right: 0;
    transform-origin: bottom right;
    text-align: left;
  }

  ${TypeCss}
`
