using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCurvatures : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCurvatures";

		public new static readonly string MRClassNameKey;

		static vtkCurvatures()
		{
			vtkCurvatures.MRClassNameKey = "class vtkCurvatures";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCurvatures.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCurvatures"));
		}

		public vtkCurvatures(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCurvatures_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCurvatures New()
		{
			vtkCurvatures result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCurvatures() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCurvatures.vtkCurvatures_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCurvatures_GetCurvatureType_01(HandleRef pThis);

		public virtual int GetCurvatureType()
		{
			return vtkCurvatures.vtkCurvatures_GetCurvatureType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCurvatures_GetInvertMeanCurvature_02(HandleRef pThis);

		public virtual int GetInvertMeanCurvature()
		{
			return vtkCurvatures.vtkCurvatures_GetInvertMeanCurvature_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_InvertMeanCurvatureOff_03(HandleRef pThis);

		public virtual void InvertMeanCurvatureOff()
		{
			vtkCurvatures.vtkCurvatures_InvertMeanCurvatureOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_InvertMeanCurvatureOn_04(HandleRef pThis);

		public virtual void InvertMeanCurvatureOn()
		{
			vtkCurvatures.vtkCurvatures_InvertMeanCurvatureOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCurvatures_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCurvatures.vtkCurvatures_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCurvatures_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCurvatures.vtkCurvatures_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCurvatures_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCurvatures NewInstance()
		{
			vtkCurvatures result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCurvatures_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCurvatures SafeDownCast(vtkObjectBase o)
		{
			vtkCurvatures vtkCurvatures = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCurvatures.vtkCurvatures_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCurvatures = (vtkCurvatures)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCurvatures.Register(null);
				}
			}
			return vtkCurvatures;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetCurvatureType_10(HandleRef pThis, int _arg);

		public virtual void SetCurvatureType(int _arg)
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureType_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetCurvatureTypeToGaussian_11(HandleRef pThis);

		public void SetCurvatureTypeToGaussian()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToGaussian_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMaximum_12(HandleRef pThis);

		public void SetCurvatureTypeToMaximum()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMaximum_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMean_13(HandleRef pThis);

		public void SetCurvatureTypeToMean()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMean_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetCurvatureTypeToMinimum_14(HandleRef pThis);

		public void SetCurvatureTypeToMinimum()
		{
			vtkCurvatures.vtkCurvatures_SetCurvatureTypeToMinimum_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCurvatures_SetInvertMeanCurvature_15(HandleRef pThis, int _arg);

		public virtual void SetInvertMeanCurvature(int _arg)
		{
			vtkCurvatures.vtkCurvatures_SetInvertMeanCurvature_15(base.GetCppThis(), _arg);
		}
	}
}
