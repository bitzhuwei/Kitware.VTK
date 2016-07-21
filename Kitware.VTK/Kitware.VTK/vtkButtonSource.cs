using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkButtonSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonSource";

		public new static readonly string MRClassNameKey;

		static vtkButtonSource()
		{
			vtkButtonSource.MRClassNameKey = "class vtkButtonSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonSource"));
		}

		public vtkButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkButtonSource.vtkButtonSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonSource_GetShoulderTextureCoordinate_03(HandleRef pThis);

		public virtual double[] GetShoulderTextureCoordinate()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_04(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetShoulderTextureCoordinate(ref double _arg1, ref double _arg2)
		{
			vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_04(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_GetShoulderTextureCoordinate_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetShoulderTextureCoordinate(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_GetShoulderTextureCoordinate_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonSource_GetTextureDimensions_06(HandleRef pThis);

		public virtual int[] GetTextureDimensions()
		{
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_GetTextureDimensions_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_GetTextureDimensions_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTextureDimensions(ref int _arg1, ref int _arg2)
		{
			vtkButtonSource.vtkButtonSource_GetTextureDimensions_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_GetTextureDimensions_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetTextureDimensions(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_GetTextureDimensions_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_GetTextureStyle_09(HandleRef pThis);

		public virtual int GetTextureStyle()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyle_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_GetTextureStyleMaxValue_10(HandleRef pThis);

		public virtual int GetTextureStyleMaxValue()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyleMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_GetTextureStyleMinValue_11(HandleRef pThis);

		public virtual int GetTextureStyleMinValue()
		{
			return vtkButtonSource.vtkButtonSource_GetTextureStyleMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_GetTwoSided_12(HandleRef pThis);

		public virtual int GetTwoSided()
		{
			return vtkButtonSource.vtkButtonSource_GetTwoSided_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkButtonSource.vtkButtonSource_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkButtonSource_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkButtonSource.vtkButtonSource_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkButtonSource NewInstance()
		{
			vtkButtonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkButtonSource vtkButtonSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonSource.vtkButtonSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonSource = (vtkButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonSource.Register(null);
				}
			}
			return vtkButtonSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetCenter_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkButtonSource.vtkButtonSource_SetCenter_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetCenter_18(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetCenter_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_19(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetShoulderTextureCoordinate(double _arg1, double _arg2)
		{
			vtkButtonSource.vtkButtonSource_SetShoulderTextureCoordinate_19(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetShoulderTextureCoordinate_20(HandleRef pThis, IntPtr _arg);

		public void SetShoulderTextureCoordinate(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetShoulderTextureCoordinate_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTextureDimensions_21(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTextureDimensions(int _arg1, int _arg2)
		{
			vtkButtonSource.vtkButtonSource_SetTextureDimensions_21(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTextureDimensions_22(HandleRef pThis, IntPtr _arg);

		public void SetTextureDimensions(IntPtr _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTextureDimensions_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTextureStyle_23(HandleRef pThis, int _arg);

		public virtual void SetTextureStyle(int _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyle_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTextureStyleToFitImage_24(HandleRef pThis);

		public void SetTextureStyleToFitImage()
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyleToFitImage_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTextureStyleToProportional_25(HandleRef pThis);

		public void SetTextureStyleToProportional()
		{
			vtkButtonSource.vtkButtonSource_SetTextureStyleToProportional_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_SetTwoSided_26(HandleRef pThis, int _arg);

		public virtual void SetTwoSided(int _arg)
		{
			vtkButtonSource.vtkButtonSource_SetTwoSided_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_TwoSidedOff_27(HandleRef pThis);

		public virtual void TwoSidedOff()
		{
			vtkButtonSource.vtkButtonSource_TwoSidedOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkButtonSource_TwoSidedOn_28(HandleRef pThis);

		public virtual void TwoSidedOn()
		{
			vtkButtonSource.vtkButtonSource_TwoSidedOn_28(base.GetCppThis());
		}
	}
}
