using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageNonMaximumSuppression : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageNonMaximumSuppression";

		public new static readonly string MRClassNameKey;

		static vtkImageNonMaximumSuppression()
		{
			vtkImageNonMaximumSuppression.MRClassNameKey = "class vtkImageNonMaximumSuppression";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageNonMaximumSuppression.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNonMaximumSuppression"));
		}

		public vtkImageNonMaximumSuppression(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNonMaximumSuppression_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageNonMaximumSuppression New()
		{
			vtkImageNonMaximumSuppression result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageNonMaximumSuppression() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(HandleRef pThis);

		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(HandleRef pThis);

		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_GetHandleBoundaries_04(HandleRef pThis);

		public virtual int GetHandleBoundaries()
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_GetHandleBoundaries_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOff_05(HandleRef pThis);

		public virtual void HandleBoundariesOff()
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_HandleBoundariesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_HandleBoundariesOn_06(HandleRef pThis);

		public virtual void HandleBoundariesOn()
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_HandleBoundariesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageNonMaximumSuppression_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNonMaximumSuppression_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageNonMaximumSuppression NewInstance()
		{
			vtkImageNonMaximumSuppression result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageNonMaximumSuppression_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageNonMaximumSuppression SafeDownCast(vtkObjectBase o)
		{
			vtkImageNonMaximumSuppression vtkImageNonMaximumSuppression = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageNonMaximumSuppression = (vtkImageNonMaximumSuppression)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageNonMaximumSuppression.Register(null);
				}
			}
			return vtkImageNonMaximumSuppression;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_SetDimensionality_12(HandleRef pThis, int _arg);

		public virtual void SetDimensionality(int _arg)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetDimensionality_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_SetHandleBoundaries_13(HandleRef pThis, int _arg);

		public virtual void SetHandleBoundaries(int _arg)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetHandleBoundaries_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_SetMagnitudeInput_14(HandleRef pThis, HandleRef input);

		public void SetMagnitudeInput(vtkImageData input)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetMagnitudeInput_14(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageNonMaximumSuppression_SetVectorInput_15(HandleRef pThis, HandleRef input);

		public void SetVectorInput(vtkImageData input)
		{
			vtkImageNonMaximumSuppression.vtkImageNonMaximumSuppression_SetVectorInput_15(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
