import React, { useState, useEffect } from 'react'
import { useRouteMatch, useHistory, NavLink } from 'react-router-dom'
import { Button, Icon, Text } from './elements'

const ButtonNavbar = ({ text, icon, iconSelected, linkTo, isOpen = true }) => {
  const { location } = useHistory()
  const { url } = useRouteMatch()
  const [isActive, setIsActive] = useState(false)

  useEffect(() => {
    setIsActive(prev => (prev = location.pathname.includes(url + linkTo)))
  }, [location.pathname, linkTo, url])

  if (isActive) {
    return (
      <Button isActive={isActive} isOpen={isOpen}>
        <Icon icon={icon} iconSelected={iconSelected} />
        <Text>{text}</Text>
      </Button>
    )
  }
  return (
    <NavLink to={`${url}${linkTo}`} style={{ textDecoration: 'none' }}>
      <Button isActive={isActive} isOpen={isOpen}>
        <Icon icon={icon} iconSelected={iconSelected} />
        <Text>{text}</Text>
      </Button>
    </NavLink>
  )
}

export default ButtonNavbar
