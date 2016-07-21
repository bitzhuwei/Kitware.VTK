using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBooleanTexture : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBooleanTexture";

		public new static readonly string MRClassNameKey;

		static vtkBooleanTexture()
		{
			vtkBooleanTexture.MRClassNameKey = "class vtkBooleanTexture";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBooleanTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBooleanTexture"));
		}

		public vtkBooleanTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBooleanTexture New()
		{
			vtkBooleanTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBooleanTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBooleanTexture.vtkBooleanTexture_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetInIn_01(HandleRef pThis);

		public virtual byte[] GetInIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInIn_01(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetInIn_02(HandleRef pThis, IntPtr data);

		public virtual void GetInIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInIn_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetInOn_03(HandleRef pThis);

		public virtual byte[] GetInOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInOn_03(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetInOn_04(HandleRef pThis, IntPtr data);

		public virtual void GetInOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInOn_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetInOut_05(HandleRef pThis);

		public virtual byte[] GetInOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetInOut_05(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetInOut_06(HandleRef pThis, IntPtr data);

		public virtual void GetInOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetInOut_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOnIn_07(HandleRef pThis);

		public virtual byte[] GetOnIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnIn_07(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOnIn_08(HandleRef pThis, IntPtr data);

		public virtual void GetOnIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnIn_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOnOn_09(HandleRef pThis);

		public virtual byte[] GetOnOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnOn_09(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOnOn_10(HandleRef pThis, IntPtr data);

		public virtual void GetOnOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnOn_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOnOut_11(HandleRef pThis);

		public virtual byte[] GetOnOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOnOut_11(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOnOut_12(HandleRef pThis, IntPtr data);

		public virtual void GetOnOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOnOut_12(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOutIn_13(HandleRef pThis);

		public virtual byte[] GetOutIn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutIn_13(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOutIn_14(HandleRef pThis, IntPtr data);

		public virtual void GetOutIn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutIn_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOutOn_15(HandleRef pThis);

		public virtual byte[] GetOutOn()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutOn_15(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOutOn_16(HandleRef pThis, IntPtr data);

		public virtual void GetOutOn(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutOn_16(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_GetOutOut_17(HandleRef pThis);

		public virtual byte[] GetOutOut()
		{
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_GetOutOut_17(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_GetOutOut_18(HandleRef pThis, IntPtr data);

		public virtual void GetOutOut(IntPtr data)
		{
			vtkBooleanTexture.vtkBooleanTexture_GetOutOut_18(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkBooleanTexture_GetThickness_19(HandleRef pThis);

		public virtual int GetThickness()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetThickness_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkBooleanTexture_GetXSize_20(HandleRef pThis);

		public virtual int GetXSize()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetXSize_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkBooleanTexture_GetYSize_21(HandleRef pThis);

		public virtual int GetYSize()
		{
			return vtkBooleanTexture.vtkBooleanTexture_GetYSize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkBooleanTexture_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkBooleanTexture_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBooleanTexture.vtkBooleanTexture_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBooleanTexture NewInstance()
		{
			vtkBooleanTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkBooleanTexture_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBooleanTexture SafeDownCast(vtkObjectBase o)
		{
			vtkBooleanTexture vtkBooleanTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBooleanTexture.vtkBooleanTexture_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBooleanTexture = (vtkBooleanTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBooleanTexture.Register(null);
				}
			}
			return vtkBooleanTexture;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInIn_27(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetInIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInIn_27(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInIn_28(HandleRef pThis, IntPtr _arg);

		public void SetInIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInIn_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInOn_29(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetInOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOn_29(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInOn_30(HandleRef pThis, IntPtr _arg);

		public void SetInOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOn_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInOut_31(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetInOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOut_31(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetInOut_32(HandleRef pThis, IntPtr _arg);

		public void SetInOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetInOut_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnIn_33(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOnIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnIn_33(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnIn_34(HandleRef pThis, IntPtr _arg);

		public void SetOnIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnIn_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnOn_35(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOnOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOn_35(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnOn_36(HandleRef pThis, IntPtr _arg);

		public void SetOnOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOn_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnOut_37(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOnOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOut_37(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOnOut_38(HandleRef pThis, IntPtr _arg);

		public void SetOnOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOnOut_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutIn_39(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOutIn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutIn_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutIn_40(HandleRef pThis, IntPtr _arg);

		public void SetOutIn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutIn_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutOn_41(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOutOn(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOn_41(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutOn_42(HandleRef pThis, IntPtr _arg);

		public void SetOutOn(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOn_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutOut_43(HandleRef pThis, byte _arg1, byte _arg2);

		public virtual void SetOutOut(byte _arg1, byte _arg2)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOut_43(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetOutOut_44(HandleRef pThis, IntPtr _arg);

		public void SetOutOut(IntPtr _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetOutOut_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetThickness_45(HandleRef pThis, int _arg);

		public virtual void SetThickness(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetThickness_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetXSize_46(HandleRef pThis, int _arg);

		public virtual void SetXSize(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetXSize_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkBooleanTexture_SetYSize_47(HandleRef pThis, int _arg);

		public virtual void SetYSize(int _arg)
		{
			vtkBooleanTexture.vtkBooleanTexture_SetYSize_47(base.GetCppThis(), _arg);
		}
	}
}
