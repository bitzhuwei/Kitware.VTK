using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformTextureCoords : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformTextureCoords";

		public new static readonly string MRClassNameKey;

		static vtkTransformTextureCoords()
		{
			vtkTransformTextureCoords.MRClassNameKey = "class vtkTransformTextureCoords";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformTextureCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformTextureCoords"));
		}

		public vtkTransformTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformTextureCoords New()
		{
			vtkTransformTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformTextureCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformTextureCoords.vtkTransformTextureCoords_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_AddPosition_01(HandleRef pThis, double deltaR, double deltaS, double deltaT);

		public void AddPosition(double deltaR, double deltaS, double deltaT)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_AddPosition_01(base.GetCppThis(), deltaR, deltaS, deltaT);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_AddPosition_02(HandleRef pThis, IntPtr deltaPosition);

		public void AddPosition(IntPtr deltaPosition)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_AddPosition_02(base.GetCppThis(), deltaPosition);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipROff_03(HandleRef pThis);

		public virtual void FlipROff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipROff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipROn_04(HandleRef pThis);

		public virtual void FlipROn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipROn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipSOff_05(HandleRef pThis);

		public virtual void FlipSOff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipSOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipSOn_06(HandleRef pThis);

		public virtual void FlipSOn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipSOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipTOff_07(HandleRef pThis);

		public virtual void FlipTOff()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipTOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_FlipTOn_08(HandleRef pThis);

		public virtual void FlipTOn()
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_FlipTOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformTextureCoords_GetFlipR_09(HandleRef pThis);

		public virtual int GetFlipR()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipR_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformTextureCoords_GetFlipS_10(HandleRef pThis);

		public virtual int GetFlipS()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipS_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformTextureCoords_GetFlipT_11(HandleRef pThis);

		public virtual int GetFlipT()
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_GetFlipT_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_GetOrigin_12(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetOrigin_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_GetOrigin_13(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetOrigin_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_GetPosition_14(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetPosition_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_GetPosition_15(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetPosition_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_GetScale_16(HandleRef pThis);

		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_GetScale_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_GetScale_17(HandleRef pThis, IntPtr data);

		public virtual void GetScale(IntPtr data)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_GetScale_17(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformTextureCoords_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTransformTextureCoords_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformTextureCoords.vtkTransformTextureCoords_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformTextureCoords NewInstance()
		{
			vtkTransformTextureCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformTextureCoords_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformTextureCoords SafeDownCast(vtkObjectBase o)
		{
			vtkTransformTextureCoords vtkTransformTextureCoords = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformTextureCoords.vtkTransformTextureCoords_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformTextureCoords = (vtkTransformTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformTextureCoords.Register(null);
				}
			}
			return vtkTransformTextureCoords;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetFlipR_23(HandleRef pThis, int _arg);

		public virtual void SetFlipR(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipR_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetFlipS_24(HandleRef pThis, int _arg);

		public virtual void SetFlipS(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipS_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetFlipT_25(HandleRef pThis, int _arg);

		public virtual void SetFlipT(int _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetFlipT_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetOrigin_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetOrigin_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetOrigin_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetOrigin_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetPosition_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetPosition_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetPosition_29(HandleRef pThis, IntPtr _arg);

		public virtual void SetPosition(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetPosition_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetScale_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetScale_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTransformTextureCoords_SetScale_31(HandleRef pThis, IntPtr _arg);

		public virtual void SetScale(IntPtr _arg)
		{
			vtkTransformTextureCoords.vtkTransformTextureCoords_SetScale_31(base.GetCppThis(), _arg);
		}
	}
}
