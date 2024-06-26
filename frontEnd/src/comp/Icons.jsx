import '../assets/css/Icons.css'

const Icons = ({Data}) => {
  return (
    <div className=''>
        {Data.map((elem, index) => (
            <div className={elem.name} key={index}>
                <img src={elem.src} alt={elem.name} />
            </div>
        ))}
    </div>
  )
}

export default Icons