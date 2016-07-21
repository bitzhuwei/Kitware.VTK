using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageResample : vtkImageReslice
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageResample";

		public new static readonly string MRClassNameKey;

		static vtkImageResample()
		{
			vtkImageResample.MRClassNameKey = "class vtkImageResample";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageResample.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResample"));
		}

		public vtkImageResample(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageResample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageResample New()
		{
			vtkImageResample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageResample.vtkImageResample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageResample() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageResample.vtkImageResample_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageResample_GetAxisMagnificationFactor_01(HandleRef pThis, int axis, HandleRef inInfo);

		public double GetAxisMagnificationFactor(int axis, vtkInformation inInfo)
		{
			return vtkImageResample.vtkImageResample_GetAxisMagnificationFactor_01(base.GetCppThis(), axis, (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageResample_GetDimensionality_02(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageResample.vtkImageResample_GetDimensionality_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageResample_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageResample.vtkImageResample_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageResample_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageResample.vtkImageResample_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageResample_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageResample NewInstance()
		{
			vtkImageResample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageResample.vtkImageResample_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageResample_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageResample SafeDownCast(vtkObjectBase o)
		{
			vtkImageResample vtkImageResample = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageResample.vtkImageResample_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageResample = (vtkImageResample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageResample.Register(null);
				}
			}
			return vtkImageResample;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageResample_SetAxisMagnificationFactor_08(HandleRef pThis, int axis, double factor);

		public void SetAxisMagnificationFactor(int axis, double factor)
		{
			vtkImageResample.vtkImageResample_SetAxisMagnificationFactor_08(base.GetCppThis(), axis, factor);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageResample_SetAxisOutputSpacing_09(HandleRef pThis, int axis, double spacing);

		public void SetAxisOutputSpacing(int axis, double spacing)
		{
			vtkImageResample.vtkImageResample_SetAxisOutputSpacing_09(base.GetCppThis(), axis, spacing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageResample_SetDimensionality_10(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageResample.vtkImageResample_SetDimensionality_10(base.GetCppThis(), _arg);
		}
	}
}
