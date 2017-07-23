meta:
  id: repeat_n_u2
  endian: le
seq:
  -
    id: count
    type: u4
  -
    id: entries
    type: u2
    repeat: expr
    repeat-expr: count
