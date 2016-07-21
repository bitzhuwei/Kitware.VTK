using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBlockIdScalars : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlockIdScalars";

		public new static readonly string MRClassNameKey;

		static vtkBlockIdScalars()
		{
			vtkBlockIdScalars.MRClassNameKey = "class vtkBlockIdScalars";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlockIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockIdScalars"));
		}

		public vtkBlockIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlockIdScalars New()
		{
			vtkBlockIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBlockIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBlockIdScalars.vtkBlockIdScalars_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlockIdScalars_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlockIdScalars_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockIdScalars_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBlockIdScalars NewInstance()
		{
			vtkBlockIdScalars result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlockIdScalars_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlockIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkBlockIdScalars vtkBlockIdScalars = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlockIdScalars = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlockIdScalars.Register(null);
				}
			}
			return vtkBlockIdScalars;
		}
	}
}
