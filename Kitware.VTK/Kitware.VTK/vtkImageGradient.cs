using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageGradient : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageGradient";

		public new static readonly string MRClassNameKey;

		static vtkImageGradient()
		{
			vtkImageGradient.MRClassNameKey = "class vtkImageGradient";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageGradient.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGradient"));
		}

		public vtkImageGradient(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradient_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGradient New()
		{
			vtkImageGradient result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageGradient() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageGradient.vtkImageGradient_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_GetDimensionalityMaxValue_02(HandleRef pThis);

		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_GetDimensionalityMinValue_03(HandleRef pThis);

		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageGradient.vtkImageGradient_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_GetHandleBoundaries_04(HandleRef pThis);

		public virtual int GetHandleBoundaries()
		{
			return vtkImageGradient.vtkImageGradient_GetHandleBoundaries_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradient_HandleBoundariesOff_05(HandleRef pThis);

		public virtual void HandleBoundariesOff()
		{
			vtkImageGradient.vtkImageGradient_HandleBoundariesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradient_HandleBoundariesOn_06(HandleRef pThis);

		public virtual void HandleBoundariesOn()
		{
			vtkImageGradient.vtkImageGradient_HandleBoundariesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageGradient.vtkImageGradient_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageGradient_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageGradient.vtkImageGradient_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradient_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageGradient NewInstance()
		{
			vtkImageGradient result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageGradient_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageGradient SafeDownCast(vtkObjectBase o)
		{
			vtkImageGradient vtkImageGradient = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageGradient.vtkImageGradient_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageGradient = (vtkImageGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageGradient.Register(null);
				}
			}
			return vtkImageGradient;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradient_SetDimensionality_12(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageGradient.vtkImageGradient_SetDimensionality_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageGradient_SetHandleBoundaries_13(HandleRef pThis, int _arg);

		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageGradient.vtkImageGradient_SetHandleBoundaries_13(base.GetCppThis(), _arg);
		}
	}
}
