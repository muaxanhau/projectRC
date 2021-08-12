import styled, { css } from 'styled-components'
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
`
export const SearchResult = styled.div`
  display: flex;
  flex-direction: column;
  gap: var(--gap-1);
  overflow-y: auto;
`
export const Instance = styled.div`
  --font-size: calc(var(--font-size-medium) * 0.9);
  padding: var(--padding);
  padding-left: calc(var(--padding) * 2 + var(--font-size));
  font-size: var(--font-size);
  font-family: var(--font-family-2);
  color: var(--color-9-7);
  transition: var(--transition);
  cursor: pointer;
  box-shadow: -1px -1px 2px var(--color-9-10) inset;
  position: relative;

  ${({ isSelected }) =>
    isSelected &&
    css`
      color: var(--color-5);
      background-color: var(--color-2-9) !important;
      border-top-left-radius: calc(var(--font-size) / 2 + var(--padding));

      &:after {
        content: '';
        position: absolute;
        width: 1.5%;
        height: 90%;
        right: 0;
        top: 50%;
        transform: translateY(-50%);
        background-color: var(--color-4);
      }
    `}

  &:hover {
    color: var(--color-5);
    background-color: var(--color-1-10);
    border-top-left-radius: calc(var(--font-size) / 2 + var(--padding));

    &:after {
      content: '';
      position: absolute;
      width: 1.5%;
      height: 90%;
      right: 0;
      top: 50%;
      transform: translateY(-50%);
      background-color: var(--color-4);
    }
  }

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
export const DateWrapper = styled.p`
  font-size: var(--font-size-small);
  font-family: var(--font-family-2);
  color: var(--color-8-7);

  &:before {
    content: 'Tính đến ngày: ';
  }
`
export const Body = styled.div`
  height: 0;
  flex-grow: 1;
`

//=========================================

export const Table = styled.table`
  --font-size: calc(var(--font-size-medium) * 0.8);
  --height-default: 350px;
  --width-default: 300px;
  --header-height: 35px;
  --border: 1px solid var(--color-9-8);
  --padding-box: calc(var(--padding) / 2);
  --border-collapse: collapse;
  border-collapse: var(--border-collapse);
  width: ${({ width }) => width ?? 'var(--width-default)'};
  height: ${({ height }) => height ?? 'var(--height-default)'};
  font-size: var(--font-size);

  & * {
    border-collapse: var(--border-collapse);
  }

  ${({ columnWidth }) =>
    columnWidth.map(
      (width, index) => css`
        & > * > * > *:nth-child(${index + 1}) {
          width: ${width};
        }
      `
    )};
`
export const TableHeader = styled.thead`
  display: table;
  width: calc(100% - var(--scrollbar-width));
  height: var(--header-height);
  background-color: var(--color-8-9);
  border: var(--border);

  & *:not(:last-child) {
    border-right: var(--border);
  }

  & > tr {
    height: 100%;
  }
`
export const ColumnTitle = styled.th`
  font-family: var(--font-family-2);
  color: var(--color-2-5);
  word-break: break-all;
`
export const Column = styled.td`
  color: var(--color-9-7);
  padding: var(--padding-box);
  word-break: break-all;
`
export const Row = styled.tr`
  display: table;
  width: 100%;
`
export const TableBody = styled.tbody`
  height: calc(100% - var(--header-height));
  background-color: var(--color-9-10);
  border-left: var(--border);
  border-bottom: var(--border);
  display: block;
  overflow-y: scroll;
  overflow-x: hidden;

  & > ${Row} {
    border-bottom: var(--border);

    &:nth-child(even) {
      background-color: var(--color-7-11);
    }

    &:nth-child(odd) {
      background-color: var(--color-6-10);
    }

    & > ${Column} {
      border-right: var(--border);
    }
  }
`
export const SortIcon = styled.img`
  width: var(--font-size);
  aspect-ratio: 1;
  object-fit: cover;
  margin-left: calc(var(--font-size) / 4);
`
