using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAffineRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			MoveOrigin = 19,
			MoveOriginX = 17,
			MoveOriginY,
			Outside = 0,
			Rotate,
			ScaleEEdge = 6,
			ScaleNE = 9,
			ScaleNEdge = 7,
			ScaleNW = 11,
			ScaleSE,
			ScaleSEdge = 8,
			ScaleSW = 10,
			ScaleWEdge = 5,
			ShearEEdge = 13,
			ShearNEdge = 15,
			ShearSEdge,
			ShearWEdge = 14,
			Translate = 2,
			TranslateX,
			TranslateY
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAffineRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkAffineRepresentation()
		{
			vtkAffineRepresentation.MRClassNameKey = "class vtkAffineRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAffineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAffineRepresentation"));
		}

		public vtkAffineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation_GetTolerance_01(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetTolerance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation_GetToleranceMaxValue_02(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetToleranceMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation_GetToleranceMinValue_03(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_GetToleranceMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation_GetTransform_04(HandleRef pThis, HandleRef t);

		public virtual void GetTransform(vtkTransform t)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_GetTransform_04(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAffineRepresentation.vtkAffineRepresentation_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAffineRepresentation NewInstance()
		{
			vtkAffineRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation.vtkAffineRepresentation_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAffineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAffineRepresentation vtkAffineRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation.vtkAffineRepresentation_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAffineRepresentation = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAffineRepresentation.Register(null);
				}
			}
			return vtkAffineRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation_SetTolerance_09(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_SetTolerance_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation_ShallowCopy_10(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAffineRepresentation.vtkAffineRepresentation_ShallowCopy_10(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
