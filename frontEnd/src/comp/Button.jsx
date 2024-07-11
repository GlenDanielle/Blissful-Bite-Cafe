

const Button = ({Txt, Data}) => {
  return (

    <div className={Data}>
      <button>
        {Txt}
      </button>
    </div>
  )
}

export default Button