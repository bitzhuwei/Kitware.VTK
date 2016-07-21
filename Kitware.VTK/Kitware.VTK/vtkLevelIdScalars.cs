using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLevelIdScalars : vtkHierarchicalBoxDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLevelIdScalars";

		public new static readonly string MRClassNameKey;

		static vtkLevelIdScalars()
		{
			vtkLevelIdScalars.MRClassNameKey = "class vtkLevelIdScalars";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLevelIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLevelIdScalars"));
		}

		public vtkLevelIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLevelIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLevelIdScalars New()
		{
			vtkLevelIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLevelIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLevelIdScalars.vtkLevelIdScalars_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLevelIdScalars_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkLevelIdScalars_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLevelIdScalars.vtkLevelIdScalars_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLevelIdScalars_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLevelIdScalars NewInstance()
		{
			vtkLevelIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkLevelIdScalars_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLevelIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkLevelIdScalars vtkLevelIdScalars = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLevelIdScalars.vtkLevelIdScalars_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLevelIdScalars = (vtkLevelIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLevelIdScalars.Register(null);
				}
			}
			return vtkLevelIdScalars;
		}
	}
}
