using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAppendCompositeDataLeaves : vtkCompositeDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendCompositeDataLeaves";

		public new static readonly string MRClassNameKey;

		static vtkAppendCompositeDataLeaves()
		{
			vtkAppendCompositeDataLeaves.MRClassNameKey = "class vtkAppendCompositeDataLeaves";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendCompositeDataLeaves.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendCompositeDataLeaves"));
		}

		public vtkAppendCompositeDataLeaves(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendCompositeDataLeaves New()
		{
			vtkAppendCompositeDataLeaves result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAppendCompositeDataLeaves() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(HandleRef pThis);

		public virtual void AppendFieldDataOff()
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(HandleRef pThis);

		public virtual void AppendFieldDataOn()
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendCompositeDataLeaves_GetAppendFieldData_03(HandleRef pThis);

		public virtual int GetAppendFieldData()
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetAppendFieldData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_GetInput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCompositeDataSet GetInput(int idx)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetInput_04(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCompositeDataSet GetInput()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetInput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendCompositeDataLeaves_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendCompositeDataLeaves_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAppendCompositeDataLeaves NewInstance()
		{
			vtkAppendCompositeDataLeaves result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendCompositeDataLeaves_RemoveInput_10(HandleRef pThis, HandleRef arg0);

		public void RemoveInput(vtkDataSet arg0)
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_RemoveInput_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendCompositeDataLeaves SafeDownCast(vtkObjectBase o)
		{
			vtkAppendCompositeDataLeaves vtkAppendCompositeDataLeaves = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendCompositeDataLeaves = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendCompositeDataLeaves.Register(null);
				}
			}
			return vtkAppendCompositeDataLeaves;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendCompositeDataLeaves_SetAppendFieldData_12(HandleRef pThis, int _arg);

		public virtual void SetAppendFieldData(int _arg)
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_SetAppendFieldData_12(base.GetCppThis(), _arg);
		}
	}
}
