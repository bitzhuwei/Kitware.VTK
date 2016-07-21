using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCubeSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeSource";

		public new static readonly string MRClassNameKey;

		static vtkCubeSource()
		{
			vtkCubeSource.MRClassNameKey = "class vtkCubeSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeSource"));
		}

		public vtkCubeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeSource New()
		{
			vtkCubeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCubeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCubeSource.vtkCubeSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeSource_GetCenter_01(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_GetCenter_02(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkCubeSource.vtkCubeSource_GetCenter_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetXLength_03(HandleRef pThis);

		public virtual double GetXLength()
		{
			return vtkCubeSource.vtkCubeSource_GetXLength_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetXLengthMaxValue_04(HandleRef pThis);

		public virtual double GetXLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetXLengthMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetXLengthMinValue_05(HandleRef pThis);

		public virtual double GetXLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetXLengthMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetYLength_06(HandleRef pThis);

		public virtual double GetYLength()
		{
			return vtkCubeSource.vtkCubeSource_GetYLength_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetYLengthMaxValue_07(HandleRef pThis);

		public virtual double GetYLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetYLengthMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetYLengthMinValue_08(HandleRef pThis);

		public virtual double GetYLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetYLengthMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetZLength_09(HandleRef pThis);

		public virtual double GetZLength()
		{
			return vtkCubeSource.vtkCubeSource_GetZLength_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetZLengthMaxValue_10(HandleRef pThis);

		public virtual double GetZLengthMaxValue()
		{
			return vtkCubeSource.vtkCubeSource_GetZLengthMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCubeSource_GetZLengthMinValue_11(HandleRef pThis);

		public virtual double GetZLengthMinValue()
		{
			return vtkCubeSource.vtkCubeSource_GetZLengthMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCubeSource_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCubeSource.vtkCubeSource_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCubeSource_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCubeSource.vtkCubeSource_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCubeSource NewInstance()
		{
			vtkCubeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCubeSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCubeSource SafeDownCast(vtkObjectBase o)
		{
			vtkCubeSource vtkCubeSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCubeSource.vtkCubeSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeSource = (vtkCubeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeSource.Register(null);
				}
			}
			return vtkCubeSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetBounds_17(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkCubeSource.vtkCubeSource_SetBounds_17(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetBounds_18(HandleRef pThis, IntPtr bounds);

		public void SetBounds(IntPtr bounds)
		{
			vtkCubeSource.vtkCubeSource_SetBounds_18(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCubeSource.vtkCubeSource_SetCenter_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCubeSource.vtkCubeSource_SetCenter_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetXLength_21(HandleRef pThis, double _arg);

		public virtual void SetXLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetXLength_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetYLength_22(HandleRef pThis, double _arg);

		public virtual void SetYLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetYLength_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCubeSource_SetZLength_23(HandleRef pThis, double _arg);

		public virtual void SetZLength(double _arg)
		{
			vtkCubeSource.vtkCubeSource_SetZLength_23(base.GetCppThis(), _arg);
		}
	}
}
