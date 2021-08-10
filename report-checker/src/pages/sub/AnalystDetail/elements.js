import styled from 'styled-components'
import Images from './../../../constants/Images'
import { Polygon1 } from './../../../components/commons/styles/polygon'

export const Wrapper = styled.div`
  --width-left: 30%;
  width: 100%;
  height: 100%;
  display: flex;
  gap: var(--gap-1);
`
export const ContentLeft = styled.div`
  width: var(--width-left);
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
`
export const SearchBar = styled.div`
  display: flex;
  align-items: center;
  gap: calc(var(--gap-1) / 2);
`
export const SearchResult = styled.div`
  display: flex;
  flex-direction: column;
  overflow-y: auto;
`
export const Instance = styled.div`
  --font-size: var(--font-size-medium);
  padding: var(--padding);
  padding-left: calc(var(--padding) * 2 + var(--font-size));
  font-size: var(--font-size);
  color: var(--color-9-7);
  transition: var(--transition);
  cursor: pointer;
  position: relative;

  &:before {
    content: '';
    position: absolute;
    width: var(--font-size);
    aspect-ratio: 1;
    top: 50%;
    left: var(--padding);
    transform: translateY(-50%);
    background: url(${Images.CHECK_ICON});
    background-size: 100% 100%;
  }

  &:nth-child(even) {
    background-color: var(--color-7-10);
  }

  &:hover {
    color: var(--color-5);
    background-color: var(--color-9);
  }
`
export const ContentRight = styled.div`
  width: 0;
  flex-grow: 1;
  background-color: var(--color-9-10);
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
  padding: var(--padding);

  ${Polygon1}
`
export const Header = styled.div`
  display: flex;
  gap: var(--gap-2);
`
export const InfoArea = styled.div`
  width: 0;
  flex-grow: 1;
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
`
export const ItemName = styled.p`
  font-size: var(--font-size-medium);
  font-weight: var(--font-bold);
  color: var(--color-5);
  text-transform: uppercase;
  font-family: var(--font-family-2);
`
export const Date = styled.p`
  font-size: var(--font-size-small);
  font-family: var(--font-family-2);
  color: var(--color-8-7);

  &:before {
    content: 'Ngày: ';
  }
`
export const Body = styled.div`
  overflow-y: auto;
`
