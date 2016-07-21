using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageGradientMagnitude : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradientMagnitude";

		public new static readonly string MRClassNameKey;

		static vtkImageGradientMagnitude()
		{
			vtkImageGradientMagnitude.MRClassNameKey = "class vtkImageGradientMagnitude";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGradientMagnitude.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradientMagnitude"));
		}

		public vtkImageGradientMagnitude(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradientMagnitude_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGradientMagnitude New()
		{
			vtkImageGradientMagnitude result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageGradientMagnitude() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageGradientMagnitude.vtkImageGradientMagnitude_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(HandleRef pThis);

		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_GetDimensionalityMinValue_03(HandleRef pThis);

		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_GetHandleBoundaries_04(HandleRef pThis);

		public virtual int GetHandleBoundaries()
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_GetHandleBoundaries_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradientMagnitude_HandleBoundariesOff_05(HandleRef pThis);

		public virtual void HandleBoundariesOff()
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_HandleBoundariesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradientMagnitude_HandleBoundariesOn_06(HandleRef pThis);

		public virtual void HandleBoundariesOn()
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_HandleBoundariesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradientMagnitude_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageGradientMagnitude.vtkImageGradientMagnitude_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradientMagnitude_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageGradientMagnitude NewInstance()
		{
			vtkImageGradientMagnitude result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradientMagnitude_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGradientMagnitude SafeDownCast(vtkObjectBase o)
		{
			vtkImageGradientMagnitude vtkImageGradientMagnitude = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradientMagnitude.vtkImageGradientMagnitude_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGradientMagnitude = (vtkImageGradientMagnitude)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGradientMagnitude.Register(null);
				}
			}
			return vtkImageGradientMagnitude;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradientMagnitude_SetDimensionality_12(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_SetDimensionality_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradientMagnitude_SetHandleBoundaries_13(HandleRef pThis, int _arg);

		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageGradientMagnitude.vtkImageGradientMagnitude_SetHandleBoundaries_13(base.GetCppThis(), _arg);
		}
	}
}
