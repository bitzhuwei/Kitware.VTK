using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContextTransform : vtkAbstractContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextTransform";

		public new static readonly string MRClassNameKey;

		static vtkContextTransform()
		{
			vtkContextTransform.MRClassNameKey = "class vtkContextTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextTransform"));
		}

		public vtkContextTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextTransform New()
		{
			vtkContextTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContextTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContextTransform.vtkContextTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextTransform_GetTransform_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_GetTransform_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextTransform_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContextTransform.vtkContextTransform_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkContextTransform_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContextTransform.vtkContextTransform_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextTransform_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContextTransform NewInstance()
		{
			vtkContextTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkContextTransform_Paint_06(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkContextTransform.vtkContextTransform_Paint_06(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextTransform_Rotate_07(HandleRef pThis, float angle);

		public virtual void Rotate(float angle)
		{
			vtkContextTransform.vtkContextTransform_Rotate_07(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkContextTransform_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContextTransform SafeDownCast(vtkObjectBase o)
		{
			vtkContextTransform vtkContextTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextTransform = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextTransform.Register(null);
				}
			}
			return vtkContextTransform;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextTransform_Scale_09(HandleRef pThis, float dx, float dy);

		public virtual void Scale(float dx, float dy)
		{
			vtkContextTransform.vtkContextTransform_Scale_09(base.GetCppThis(), dx, dy);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextTransform_Translate_10(HandleRef pThis, float dx, float dy);

		public virtual void Translate(float dx, float dy)
		{
			vtkContextTransform.vtkContextTransform_Translate_10(base.GetCppThis(), dx, dy);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkContextTransform_Update_11(HandleRef pThis);

		public override void Update()
		{
			vtkContextTransform.vtkContextTransform_Update_11(base.GetCppThis());
		}
	}
}
