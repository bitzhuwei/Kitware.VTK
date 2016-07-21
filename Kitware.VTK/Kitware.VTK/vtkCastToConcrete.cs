using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCastToConcrete : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCastToConcrete";

		public new static readonly string MRClassNameKey;

		static vtkCastToConcrete()
		{
			vtkCastToConcrete.MRClassNameKey = "class vtkCastToConcrete";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCastToConcrete.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCastToConcrete"));
		}

		public vtkCastToConcrete(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCastToConcrete_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCastToConcrete New()
		{
			vtkCastToConcrete result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCastToConcrete() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCastToConcrete.vtkCastToConcrete_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCastToConcrete_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCastToConcrete_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCastToConcrete.vtkCastToConcrete_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCastToConcrete_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCastToConcrete NewInstance()
		{
			vtkCastToConcrete result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCastToConcrete_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCastToConcrete SafeDownCast(vtkObjectBase o)
		{
			vtkCastToConcrete vtkCastToConcrete = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCastToConcrete.vtkCastToConcrete_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCastToConcrete = (vtkCastToConcrete)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCastToConcrete.Register(null);
				}
			}
			return vtkCastToConcrete;
		}
	}
}
