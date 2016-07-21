using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractVectorComponents : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVectorComponents";

		public new static readonly string MRClassNameKey;

		static vtkExtractVectorComponents()
		{
			vtkExtractVectorComponents.MRClassNameKey = "class vtkExtractVectorComponents";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractVectorComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVectorComponents"));
		}

		public vtkExtractVectorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractVectorComponents New()
		{
			vtkExtractVectorComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractVectorComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractVectorComponents.vtkExtractVectorComponents_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOff_01(HandleRef pThis);

		public virtual void ExtractToFieldDataOff()
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_ExtractToFieldDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractVectorComponents_ExtractToFieldDataOn_02(HandleRef pThis);

		public virtual void ExtractToFieldDataOn()
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_ExtractToFieldDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractVectorComponents_GetExtractToFieldData_03(HandleRef pThis);

		public virtual int GetExtractToFieldData()
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_GetExtractToFieldData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_GetVxComponent_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetVxComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVxComponent_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_GetVyComponent_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetVyComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVyComponent_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_GetVzComponent_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetVzComponent()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_GetVzComponent_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractVectorComponents_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractVectorComponents_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractVectorComponents.vtkExtractVectorComponents_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractVectorComponents NewInstance()
		{
			vtkExtractVectorComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVectorComponents_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractVectorComponents SafeDownCast(vtkObjectBase o)
		{
			vtkExtractVectorComponents vtkExtractVectorComponents = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVectorComponents.vtkExtractVectorComponents_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractVectorComponents = (vtkExtractVectorComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractVectorComponents.Register(null);
				}
			}
			return vtkExtractVectorComponents;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractVectorComponents_SetExtractToFieldData_12(HandleRef pThis, int _arg);

		public virtual void SetExtractToFieldData(int _arg)
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_SetExtractToFieldData_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractVectorComponents_SetInput_13(HandleRef pThis, HandleRef input);

		public new virtual void SetInput(vtkDataSet input)
		{
			vtkExtractVectorComponents.vtkExtractVectorComponents_SetInput_13(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
