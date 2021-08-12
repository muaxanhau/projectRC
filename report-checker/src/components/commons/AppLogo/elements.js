import styled from 'styled-components'
import Images from '../../../constants/Images'

const sizeArr = {
  small: 'var(--img-size-small)',
  medium: 'var(--img-size-medium)',
  large: 'var(--img-size-large)',
  get default () {
    return this.small
  }
}
export const Wrapper = styled.div`
  --background-url: url(${Images.APP_LOGO.STYLE_1});
  width: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  aspect-ratio: 1;
  height: fit-content;
  flex-shrink: 0;
  background: var(--background-url);
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center;
  transition: var(--transition);

  &:hover {
    --background-url: url(${Images.APP_LOGO.STYLE_2});
  }
`
