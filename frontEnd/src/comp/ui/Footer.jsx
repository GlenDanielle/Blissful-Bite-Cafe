import './css/Footer.css'
import banner from '/assets/banner.png'

const Footer = () => {
  return (
    <div className='FooterContainer'>
        <div className='FooterComp'>

            <div className='BannerContainer'>
                <img className='BannerImg' src={banner} alt='banner'></img>
                
                <p>
                    blissful bite cafe, where every bite is a delight
                </p>

            </div>

            <hr></hr>

            <div className='SocialsContainer'>

            </div>

        </div>
    </div>
  ) 
}
export default Footer