import '../assets/css/Menu.css'

import Images from '../comp/Images.jsx'
import Button from '../comp/Button.jsx'
import Icons from '../comp/Icons.jsx'

const Menu = () => {
    const ButtonAddToCartData = ['Add', 'AddToCartButton']
    const QuantityIncrement = ['+', 'QuantityIncrement']
    const QuantityDecrement = ['-', 'QuantityDecrement']
    var Data = []

    for (let i = 0; i < Images.length; i++) {
        if(i>1 && i<5){
            Data = [...Data, Images[i]];
        }
    }
    
  return (
    <div>
        <div className='MenuBackground'>

            <Icons Data={Data}/>

            <div className='HeaderContainer'>
                <img src={Images[1].src} alt={Images[1].name}></img>
                <div className='BellContainer'>
                    <img src='https://www.svgrepo.com/show/265725/tray-food.svg' alt='bell'/>
                    <div className='SemiCircle'></div>
                </div>
            </div>

            <div className='ProductBackground'>
                <div className='MenuContainer'>
                    <div className='ProductContainer'>
                        <div className='ImageTitleHolder'>
                            <img src='https://picsum.photos/200/100'></img>
                            <p>Ungeziefer</p>
                        </div>
                        
                        <form className='OptionHolder'>
                            <label htmlFor="Size">Serving sizes</label>
                            <select id="Size">
                            <option value="Small">Small (8oz)</option>
                            <option value="Medium">Medium (12oz)</option>
                            <option value="Large">Large (16oz)</option>
                            </select>
                        </form>

                        <form className='RequestInputHolder'>
                            <label>Request:</label>
                            <input type='text' placeholder='Type Anything...'/>
                        </form>
                    </div>
                    <div className='MenuFooterContainer'>
                        <div>
                            <label>
                                Quantity:
                            </label>
                            <div className='QuantitySelectorContainer'>
                                <Button Txt={QuantityDecrement[0]}/>
                                <hr/>
                                <p>
                                    1
                                </p>
                                <hr/>
                                <Button Txt={QuantityIncrement[0]}/>
                            </div>
                        </div>

                        <div className={ButtonAddToCartData[1]}>
                            <Button Txt={ButtonAddToCartData[0]}/>
                        </div>
                    
                    </div>
                    <div></div>
                </div>
            </div>

        </div>
    </div>
  )
}

export default Menu