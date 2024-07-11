import '../assets/css/LandingPage.css'
import Images from '../comp/Images.jsx'
import Statements from '../comp/Statements.jsx'
import Button from '../comp/Button.jsx'


const LandingPage = () => {
  return (
    <>
    <div className="LandingPageBg">
      <div className="TopBorder"/>
      <div className="TopClip"/>
      <img className= "BBCLogo" src={Images[5].src} alt={Images[5].name}/>
      <p className='BBCPhrase'>
        “Discover a world of culinary delights with <b>Blissful Bite Cafe</b>, where every dish is crafted to perfection and delivered right to your door.”
      </p>
      <div className='MiddleClip'/>
      <img className='PancakeSample' src={Images[6].src} alt={Images[6].name} />
      <div className='ContentsContainer'>
        <div className='SubTitles'>
          <div className='Sub name1'>
            Browse our menu
          </div>
          <div className='Sub name2'>
            Customize Your Order
          </div>
          <div className='Sub name3'>
            Checkout Securely
          </div>
          <div className='Sub name4'>
            Enjoy Your Meal
          </div>
        </div>  
        <div className='InstructContainer'>
          <div className='Section'>
            <img className='Burger Tleft' src={Images[7].src} alt={Images[7].name} />
            <p className={Statements[0].classname}>
              {Statements[0].statement}
            </p>
          </div>
          <div className='Section1'>
            <img className='Burger Tright' src={Images[8].src} alt={Images[8].name} />
            <p className={Statements[1].classname}>
              {Statements[1].statement}
            </p>
          </div>

          
          <Button Txt="Order Now!" Data="OrderNow"/>


          <div className='Section2'>
            <img className='Burger Bleft' src={Images[9].src} alt={Images[9].name} />
            <p className={Statements[2].classname}>
              {Statements[2].statement}
            </p>
          </div>
          <div className='Section3'>
            <img className='Burger Bright' src={Images[10].src} alt={Images[10].name} />
            <p className={Statements[3].classname}>
              {Statements[3].statement}
            </p>
          </div>
        </div>
      </div>
      <img className={Images[11].name} src={Images[11].src} alt={Images[11].name} />
      <img className={Images[12].name} src={Images[12].src} alt={Images[12].name}/>
      <img className={Images[13].name} src={Images[13].src} alt={Images[13].name}/>
      <img className={Images[14].name} src={Images[14].src} alt={Images[14].name}/>
      <img className={Images[15].name} src={Images[15].src} alt={Images[15].name}/>
      <img className={Images[16].name} src={Images[16].src} alt={Images[16].name}/>

    </div>

    </>
  )
}

export default LandingPage