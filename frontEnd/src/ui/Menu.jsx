import '../assets/css/Menu.css'

import Images from '../comp/Images.jsx'

const Menu = () => {
    //bell svg link https://www.svgrepo.com/show/265725/tray-food.svg
  return (
    <div>
        <div className=''>
            <div className='HeaderContainer'>
                <img src={Images[1].src} alt={Images[1].name}></img>
                <div className='BellContainer'>
                    <img src='https://www.svgrepo.com/show/265725/tray-food.svg' alt='bell'/>
                    <div className='SemiCircle'></div>
                </div>
            </div>
            <img className={Images[3].name} src={Images[3].src} alt={Images[3].name}></img>
            <img className={Images[2].name} src={Images[2].src} alt={Images[2].name}></img>

            <div className='ProductBackground'>
                <div className='MenuContainer'>
                </div>
            </div>
        </div>
    </div>
  )
}

export default Menu