using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphInternals : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphInternals";

		public new static readonly string MRClassNameKey;

		static vtkGraphInternals()
		{
			vtkGraphInternals.MRClassNameKey = "class vtkGraphInternals";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphInternals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphInternals"));
		}

		public vtkGraphInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphInternals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphInternals New()
		{
			vtkGraphInternals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphInternals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphInternals.vtkGraphInternals_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphInternals_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraphInternals_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphInternals.vtkGraphInternals_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphInternals_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphInternals NewInstance()
		{
			vtkGraphInternals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphInternals_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphInternals SafeDownCast(vtkObjectBase o)
		{
			vtkGraphInternals vtkGraphInternals = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphInternals.vtkGraphInternals_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphInternals = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphInternals.Register(null);
				}
			}
			return vtkGraphInternals;
		}
	}
}
