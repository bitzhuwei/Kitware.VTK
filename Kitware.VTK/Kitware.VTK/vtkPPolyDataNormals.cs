using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPPolyDataNormals : vtkPolyDataNormals
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPPolyDataNormals";

		public new static readonly string MRClassNameKey;

		static vtkPPolyDataNormals()
		{
			vtkPPolyDataNormals.MRClassNameKey = "class vtkPPolyDataNormals";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPPolyDataNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPPolyDataNormals"));
		}

		public vtkPPolyDataNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPPolyDataNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPPolyDataNormals New()
		{
			vtkPPolyDataNormals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPPolyDataNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPPolyDataNormals.vtkPPolyDataNormals_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPPolyDataNormals_GetPieceInvariant_01(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_GetPieceInvariant_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPPolyDataNormals_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPPolyDataNormals_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPPolyDataNormals.vtkPPolyDataNormals_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPPolyDataNormals_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPPolyDataNormals NewInstance()
		{
			vtkPPolyDataNormals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPPolyDataNormals_PieceInvariantOff_06(HandleRef pThis);

		public virtual void PieceInvariantOff()
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_PieceInvariantOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPPolyDataNormals_PieceInvariantOn_07(HandleRef pThis);

		public virtual void PieceInvariantOn()
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_PieceInvariantOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPPolyDataNormals_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPPolyDataNormals SafeDownCast(vtkObjectBase o)
		{
			vtkPPolyDataNormals vtkPPolyDataNormals = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPolyDataNormals.vtkPPolyDataNormals_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPPolyDataNormals = (vtkPPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPPolyDataNormals.Register(null);
				}
			}
			return vtkPPolyDataNormals;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPPolyDataNormals_SetPieceInvariant_09(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPPolyDataNormals.vtkPPolyDataNormals_SetPieceInvariant_09(base.GetCppThis(), _arg);
		}
	}
}
