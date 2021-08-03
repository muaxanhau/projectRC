import styled from 'styled-components'

export const Container = styled.div`
  position: fixed;
  inset: 0;
  display: flex;
  justify-content: center;
  align-items: center;
`
export const Wrapper = styled.div`
  font-size: 6vw;
  font-family: var(--font-family-2);
  background: linear-gradient(
    45deg,
    var(--color-4),
    var(--color-5),
    var(--color-1)
  );
  -webkit-background-clip: text;
  color: transparent;
  position: relative;

  &:before,
  &:after {
    --line-weight: 1vw;
    content: '';
    position: absolute;
    width: 0;
    height: 0;
    background: linear-gradient(
      45deg,
      var(--color-4),
      var(--color-5),
      var(--color-1)
    );

    animation: kf-show 1.2s 0.5s ease-in-out forwards;
    @keyframes kf-show {
      0% {
        height: var(--line-weight);
        width: 0;
      }
      70% {
        height: var(--line-weight);
        width: calc(100%);
      }
      100% {
        width: calc(100%);
        height: calc(100%);
      }
    }
  }
  &:before {
    top: calc((var(--line-weight) + var(--padding)) * -1);
    right: calc(var(--line-weight) + var(--padding));
    clip-path: polygon(
      0 0,
      100% 0,
      100% var(--line-weight),
      var(--line-weight) var(--line-weight),
      var(--line-weight) 100%,
      0 100%
    );
  }

  &:after {
    bottom: calc((var(--line-weight) + var(--padding)) * -1);
    left: calc(var(--line-weight) + var(--padding));
    clip-path: polygon(
      0 calc(100% - var(--line-weight)),
      calc(100% - var(--line-weight)) calc(100% - var(--line-weight)),
      calc(100% - var(--line-weight)) 0,
      100% 0,
      100% 100%,
      0 100%
    );
  }
`
