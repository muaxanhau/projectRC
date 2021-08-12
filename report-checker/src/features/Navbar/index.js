import React from 'react'
import { Wrapper } from './elements'
import ButtonNavbar from './../../components/commons/ButtonNavbar/index'
import { useSelector } from 'react-redux'
import { selectNavbar } from './navbarSlice'

const Navbar = ({ data = [] }) => {
  const navbar = useSelector(selectNavbar)

  return (
    <Wrapper>
      {data?.map((item, index) => (
        <ButtonNavbar
          key={index}
          text={item.name}
          icon={item.icon.normal}
          iconSelected={item.icon.selected}
          linkTo={item.linkTo}
          isOpen={navbar.isOpen}
        />
      ))}
    </Wrapper>
  )
}

export default Navbar
